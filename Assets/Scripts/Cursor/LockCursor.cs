using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCursor : MonoBehaviour
{
    public static bool isCursorLock = true;
    private void Update()
    {
        if (isCursorLock)
        {
            CursorLock();
        }
        else
        {
            CursorShow();
        }
    }

    void CursorLock()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;
    }

    void CursorShow()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
