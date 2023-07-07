using UnityEngine;
using System.Collections;

public class EagleController : MonoBehaviour
{
    public Animator animator;
    public GameObject jailbroke;
    void Update()
	{
        if(jailbroke.activeSelf){
            if (this.ContainsParam(animator,"Leave"))
            {
                animator.SetTrigger("Leave");
                StartCoroutine(DestroyMe());
            }
        }
        
    }
     public bool ContainsParam(Animator _Anim, string _ParamName)
    {
        foreach (AnimatorControllerParameter param in _Anim.parameters)
        {
            if (param.name == _ParamName) return true;
        }
        return false;
    }

     IEnumerator DestroyMe(){
        yield return new WaitForSeconds (2f);
         Destroy(gameObject);           
    }
}
