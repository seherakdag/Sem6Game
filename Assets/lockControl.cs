using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockControl : MonoBehaviour
{
    private int[] result, correctCombination;
    private void Start()
    {
        result = new int[] { 1, 1, 1, 1};
        correctCombination = new int[] { 3, 12, 6, 14 };
        Rotate.Rotated += CheckResults;
    }

    private void CheckResults(string wheelName, int number)
    {
        switch (wheelName)
        {

            case "Lock1":
                result[0] = number;
                break;

            case "Lock2":
                result[1] = number;
                break;

            case "Lock3":
                result[2] = number;
                break;

            case "Lock4":
                result[3] = number;
                break;

        }

        if (result[0] == correctCombination[0] && result[1] == correctCombination[1] && result[2] == correctCombination[2] && result[3] == correctCombination[3])
        {
            Debug.Log("Opened");
        }

    }

    private void OnDestroy()
    {
        Rotate.Rotated -= CheckResults;

    }

}
