using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Do : MonoBehaviour
{

    public void CheckSuccess()
    {
        changescenes.PreviousScene = SceneManager.GetActiveScene().name;

        bool success = true;
        
        if(Lab1.problem_num == 0)
        {
            int i = 4;
            if (Lab1.total_num != 4) success = false;
            else
            {
                while(i > 0)
                {
                    Destroy(Lab1.history.Pop());
                    var str = Lab1.selected.Pop();
                    Debug.Log(str);
                    if (i == 1)
                    {
                        if (!str.Equals("N")) success = false;
                    }
                    else
                        if (!str.Equals("H")) success = false;
                    Debug.Log(success);
                    i--;
                }

            }
        }
        else if (Lab1.problem_num == 1)
        {
            int i = 3;
            if (Lab1.total_num != 3) success = false;
            else
            {
                while (i > 0)
                {
                    Destroy(Lab1.history.Pop());
                    var str = Lab1.selected.Pop();
                    Debug.Log(str);
                    if (i == 1)
                    {
                        if (!str.Equals("C")) success = false;
                    }
                    else
                        if (!str.Equals("O")) success = false;
                    Debug.Log(success);
                    i--;
                }

            }
        }
        else if (Lab1.problem_num == 2)
        {
            int i = 3;
            if (Lab1.total_num != 3) success = false;
            else
            {
                while (i > 0)
                {
                    Destroy(Lab1.history.Pop());
                    var str = Lab1.selected.Pop();
                    Debug.Log(str);
                    if (i == 1)
                    {
                        if (!str.Equals("O")) success = false;
                    }
                    else
                        if (!str.Equals("H")) success = false;
                    Debug.Log(success);
                    i--;
                }

            }
        }
        Lab1.total_num = 0;

        if (success == true) SceneManager.LoadScene("Reward");
        else SceneManager.LoadScene("Fail");
    }
}
