using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoopAssignment : MonoBehaviour
{
   
    void Start()
    {
        for(int i = 1; i <= 10; i++){
            Debug.Log($"5 * {i} = {Multiply(5, i)}");
        }
    }

    int Multiply(int num1, int num2){
        return num1 * num2;
    }


}
