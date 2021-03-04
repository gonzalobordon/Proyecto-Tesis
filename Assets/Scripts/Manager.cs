using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public int saldo = 4800;
    public int dia = 1;
    public Text Moneda;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Moneda.text = saldo.ToString();
    }
    
    public void AumentarSaldo()
    {
        int aumento = 100;
        saldo += 100;
    }

    public void DisminuirSaldo()
    {
        int baja = 100;
        saldo -= 100;
    }

}
