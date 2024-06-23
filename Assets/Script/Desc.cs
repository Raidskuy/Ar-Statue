using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Desc : MonoBehaviour
{
    [Header("Deskripsi Planet")]
    public TrackableAR [] tr;
    public string [] nama;
    [TextArea]
    public string [] desc;

    [Header("UI Deskripsi")]
    public Text txtnama;
    public Text txtdesc;
    public GameObject goNama;
    public GameObject goDesc;

    public bool[] cekMarker;
    int countMarker;
    
    // Start is called before the first frame update
    void Start()
    {
        cekMarker = new bool[tr.Length]; // panjang bool cek marker mengikuty jumlah marker
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < tr.Length; i++)
        {
            if(tr[i].GetMarker())
            {
                txtnama.text = nama[i];
                txtdesc.text = desc[i];

                if(!cekMarker[i]) //jika marker belum terdeteksi
                {
                    cekMarker[i] = true;
                    countMarker++; //increment count marker
                }
            } else
            {
                if(cekMarker[i])
                {
                    cekMarker[i] = false;
                    countMarker--; //decrement count marker
                }
            }
        }

        descpanel();
    }   
     private void descpanel()
     {
        if(countMarker == 0){
            goNama.SetActive(false);
            goDesc.SetActive(false);
        } else {
            goNama.SetActive(true);
            goDesc.SetActive(true);
        }
     }
}
