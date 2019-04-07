using UnityEngine;

public class DragonController : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        float moviment = Input.GetAxis("Vertical"); // 0 > 1
        print("moviment = " + moviment);

        animator.SetFloat("walk", moviment);
        animator.SetFloat("run", moviment);
    }

    public void OnButtonFlyClicked()
    {
        animator.SetTrigger("fly");
    }

    public void OnButtonPlayAnimationCustomClicked(string nameState)
    {
        animator.Play(nameState);
    }
}
