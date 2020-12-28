using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCursor : MonoBehaviour
{
    public Texture2D cursorText;

    private void Start()
    {
        Cursor.SetCursor(cursorText, Vector2.zero, CursorMode.Auto);
    }
}
