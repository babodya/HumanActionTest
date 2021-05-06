using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject archer;
    [SerializeField]
    GameObject knight;
    [SerializeField]
    GameObject mageDark;
    [SerializeField]
    GameObject zombie;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {

            archer.SetActive(true);
            knight.SetActive(false);
            mageDark.SetActive(false);
            zombie.SetActive(false);

        } else if (Input.GetKey(KeyCode.B))
        {

            archer.SetActive(false);
            knight.SetActive(true);
            mageDark.SetActive(false);
            zombie.SetActive(false);

        } else if (Input.GetKey(KeyCode.C))
        {

            archer.SetActive(false);
            knight.SetActive(false);
            mageDark.SetActive(true);
            zombie.SetActive(false);

        } else if (Input.GetKey(KeyCode.D))
        {

            archer.SetActive(false);
            knight.SetActive(false);
            mageDark.SetActive(false);
            zombie.SetActive(true);

        }
    }
}
