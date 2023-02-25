using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControlChange : MonoBehaviour
{
    
    [SerializeField] private GameObject RebindButtion;
    [SerializeField] private GameObject Rebindingwaiting;
    [SerializeField] private InputActionReference MoveUP = null;
    [SerializeField] private TMP_Text displayButtion = null;
    private InputActionRebindingExtensions.RebindingOperation rebindingOperation;

    void OnMouseUpAsButton()
    {
        Rebinding();
    }
    void Rebinding()
    {
        RebindButtion.SetActive(false);
        Rebindingwaiting.SetActive(true);
        rebindingOperation = MoveUP.action.PerformInteractiveRebinding().WithControlsExcluding("Mouse")
            .OnMatchWaitForAnother(0.1f)
            .WithControlsExcluding("Mouse")
            .OnComplete(operation => RebindDone())
            .Start();
    }

    private void RebindDone()
    {
        int BidingIndex = MoveUP.action.GetBindingIndexForControl(MoveUP.action.controls[0]);
        displayButtion.text = InputControlPath.ToHumanReadableString(MoveUP.action.bindings[0].effectivePath,
            InputControlPath.HumanReadableStringOptions.OmitDevice);


        RebindButtion.SetActive(false);
        Rebindingwaiting.SetActive(true);
        rebindingOperation.Dispose();
    }
}
