using UnityEngine;

public class LetterButtonsScript : MonoBehaviour
{
    private bool checked = false;

    private void Update()
    {
        if(checked == false){

          if((iPhone.generation.ToString()).IndexOf("iPad") > -1){
            for(int i = 0; i < this.transform.childCount; i++){
              transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        checked = true;
    }
}
}
