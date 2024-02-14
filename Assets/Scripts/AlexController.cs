using UnityEngine;
using UnityEngine.UI;

public class AlexController : MonoBehaviour
{
    public Animator animator;
    public Button walkButton;
    public Button jumpButton;
    public Button attackButton;

    private void Start()
    {
        walkButton.onClick.AddListener(PlayWalkAnimation);
        jumpButton.onClick.AddListener(PlayJumpAnimation);
        attackButton.onClick.AddListener(PlayAttackAnimation);
    }

    private void PlayWalkAnimation()
    {
        animator.SetTrigger("Walk");
    }

    private void PlayJumpAnimation()
    {
        animator.SetTrigger("Jump");
    }

    private void PlayAttackAnimation()
    {
        animator.SetTrigger("Attack");
    }
}
