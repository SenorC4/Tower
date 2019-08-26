using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldBlock : MonoBehaviour
{
    // Start is called before the first frame update

    #region Singleton

    public static GoldBlock instance;

    private void Awake()
    {
        instance = this;
    }

    #endregion


    public GameObject gold;
}
