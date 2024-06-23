using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockCursor : MonoBehaviour
{
    private void Start()
    {
        CursorManager.SetCursorState(CursorLockMode.None, true);
    }
}
