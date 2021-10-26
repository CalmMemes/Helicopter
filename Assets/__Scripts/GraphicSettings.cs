using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class GraphicSettings : MonoBehaviour
{

    public Dropdown dropDown;
    // Start is called before the first frame update
    void Start()
    {
        //QualitySettings.names;
        dropDown.ClearOptions();
        dropDown.AddOptions(QualitySettings.names.ToList());
        dropDown.value = QualitySettings.GetQualityLevel();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetQuality()
    {
        QualitySettings.SetQualityLevel(dropDown.value);
    }
}
