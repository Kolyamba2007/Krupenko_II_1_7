using UnityEngine;
using System.Collections;
using static UnityEngine.InputSystem.InputAction;
using UnityEngine.InputSystem;

//Управление персонажа осуществляется с помощью (space - left shift - a - d) или стрелочек //Рекомендую управление стрелочками

[RequireComponent(typeof(Rigidbody), typeof(CapsuleCollider), typeof(PlayerStatsComponent))]
public class PlayerController : MonoBehaviour
{
    public Animator animator;
    public NewInputSystem controls;
    public PlayerStatsComponent stats;
    Rigidbody rb;
    CapsuleCollider playerCollider;
    [HideInInspector]
    public bool isGrounded ,isReturn, isDirt;
    bool isInvokingCoroutine, isSliding;
    enum Side {left = -1, middle = 0, right = 1};
    Side currentSide = Side.middle, lastSide;

    private void Awake()
    {
        if (animator == null || stats == null) throw new MissingReferenceException();

        controls = new NewInputSystem();
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerCollider = GetComponent<CapsuleCollider>();
    }
    private void FixedUpdate()
    {
        stats.speed += 0.0005f;
        animator.SetFloat("speed", stats.speed / 10);

        if(!isReturn)
        {
            Run();
        }
    }
    private void OnEnable()
    {
        EnableInput(true);
        SubscribeInput(true);
    }
    private void OnDisable()
    {
        SubscribeInput(false);
    }

    private void EnableInput(bool enabled)
    {
        if (enabled)
        {
            controls.Arrows.Enable();
#if UNITY_EDITOR
            controls.WASD.Enable();
#endif
        }
        else
        {
            controls.Arrows.Disable();
#if UNITY_EDITOR
            controls.WASD.Disable();
#endif
        }
    }
    private void SubscribeInput(bool isSubscribed)
    {
        if (isSubscribed)
        {
#if UNITY_EDITOR
            controls.WASD.Jump.started += Jump;
            controls.WASD.Slide.started += Slide;
            controls.WASD.RightMove.started += RightMove;
            controls.WASD.LeftMove.started += LeftMove;
#endif
            controls.Arrows.Jump.started += Jump;
            controls.Arrows.Slide.started += Slide;
            controls.Arrows.RightMove.started += RightMove;
            controls.Arrows.LeftMove.started += LeftMove;
        }
        else
        {
#if UNITY_EDITOR
            controls.WASD.Jump.started -= Jump;
            controls.WASD.Slide.started -= Slide;
            controls.WASD.RightMove.started -= RightMove;
            controls.WASD.LeftMove.started -= LeftMove;
            controls.WASD.Disable();
#endif
            controls.Arrows.Jump.started -= Jump;
            controls.Arrows.Slide.started -= Slide;
            controls.Arrows.RightMove.started -= RightMove;
            controls.Arrows.LeftMove.started -= LeftMove;
            controls.Arrows.Disable();
        }
    }

    void Run() //Двигает персонажа постоянно вперед
    {
        Vector3 newMovePos = new Vector3(0, rb.velocity.y, stats.speed);
        rb.velocity = newMovePos;
    }
    void RightMove(CallbackContext contex) //Триггер нажатия на клавишу для передвижения вправо
    {
        if(!isInvokingCoroutine && currentSide != Side.right)
        {
            lastSide = currentSide;
            currentSide++;

            if(isSliding)
            {
                StopCoroutine(Sliding());
                playerCollider.height = 1.58f;
                playerCollider.center = new Vector3(0, 0.79f, 0);

                isSliding = false;
                animator.SetBool("isSliding", false);
            }

            StartCoroutine(Move());
        }
    }
    void LeftMove(CallbackContext contex) //Триггер нажатия на клавишу для передвижения влево
    {
        if(!isInvokingCoroutine && currentSide != Side.left)
        {
            lastSide = currentSide;
            currentSide--;

            if(isSliding)
            {
                StopCoroutine(Sliding());
                playerCollider.height = 1.58f;
                playerCollider.center = new Vector3(0, 0.79f, 0);

                isSliding = false;
                animator.SetBool("isSliding", false);
            }

            StartCoroutine(Move());
        }
    }
    void Jump(CallbackContext contex) //Прыжок
    {
        if(isGrounded)
        {
            if(isSliding)
            {
                StopCoroutine(Sliding());
                playerCollider.height = 1.58f;
                playerCollider.center = new Vector3(0, 0.79f, 0);

                isSliding = false;
                animator.SetBool("isSliding", false);
            }

            rb.velocity = new Vector3(rb.velocity.x, stats.jumpForce, rb.velocity.z);

            isGrounded = false;
            animator.SetBool("isGrounded", false);
        }
    }
    void Slide(CallbackContext contex) //Подкат или резкий толчок вниз в режиме прыжка
    {
        if(isGrounded)
            {
                if(!isSliding && !isDirt)
                    StartCoroutine(Sliding());
            }
        else
            rb.velocity = new Vector3(rb.velocity.x, -stats.jumpForce, rb.velocity.z);
    }
    IEnumerator Move() //Смещение в одну из сторон
    {
        isInvokingCoroutine = true;

        float x = (int)currentSide * 3.15f;
        Vector3 targetPosition = new Vector3(x, transform.position.y, transform.position.z);

        while(transform.position.x != targetPosition.x)
        {
            if(isReturn) break;

            targetPosition = new Vector3(x, transform.position.y, transform.position.z);

            float step = stats.speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);

            yield return null; 
        }

        isInvokingCoroutine = false;
        StopCoroutine(Move());
    }
    public IEnumerator Return() //Откат положения персонажа при столкновении с препятствием
    {
        isReturn = true;
        EnableInput(false);

        rb.isKinematic = true;
        playerCollider.enabled = false;

        if(isInvokingCoroutine)
        {
            currentSide = lastSide;

            Vector3 returnPosition = new Vector3((int)currentSide * 3.15f, 1.6f, transform.position.z - 2);

            while(transform.position != returnPosition)
            {
                float step = stats.speed/2 * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, returnPosition, step);

                yield return null;
            }
        }
        else
        {
            Vector3 returnPosition = new Vector3(transform.position.x, 1.6f, transform.position.z - 5);

            while(transform.position != returnPosition)
            {
                float step = stats.speed/2 * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, returnPosition, step);

                yield return null; 
            }
        }

        rb.isKinematic = false;
        playerCollider.enabled = true;

        if(isDirt)
        {
            stats.speed *= 2;
            isDirt = false;
        }
        isGrounded = true;

        EnableInput(true);
        isReturn = false;
        StopCoroutine(Return());
    }
    IEnumerator Sliding() //Подкат
    {
        isSliding = true;
        animator.SetBool("isSliding", true);

        playerCollider.height = 0.5f;
        playerCollider.center = new Vector3(0, 0.4f, 0);

        yield return new WaitForSeconds(6/stats.speed);

        playerCollider.height = 1.58f;
        playerCollider.center = new Vector3(0, 0.79f, 0);

        isSliding = false;
        animator.SetBool("isSliding", false);
        StopCoroutine(Sliding());
    }

    //Данная часть кода была перемещена в скрипт CollisionComponent (Я не очень понял, надо ли разделять таким образом скрипт управления персонажа и скрипт коллизий игрока)
    /*void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
            animator.SetBool("isGrounded", true);
        }
        else if(collision.gameObject.tag == "Wall" && !isReturn)
        {
            GameManager.Self.SetDamage();
            stats.speed -= stats.speed * 0.1f;
            StartCoroutine(Return());
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.layer == 9 && isGrounded)
        {
            isGrounded = false;
            animator.SetBool("isGrounded", false);
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        isDirt = true;
        if(collision.gameObject.tag == "Dirt")
            stats.speed /= 2;
    }

    void OnTriggerExit(Collider collision)
    {
        isDirt = false;
        if(collision.gameObject.tag == "Dirt")
            stats.speed *= 2;
    }*/
}
