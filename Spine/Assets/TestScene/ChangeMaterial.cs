using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;
using Spine;
using UnityEngine.UI;

public class ChangeMaterial : MonoBehaviour
{

    public GameObject SpineCG;
    public GameObject SpineCG2;
    public GameObject SpineCG2_Gun;
    public SpriteRenderer SampleImage;
    public Image SampleImage2;

    public Material _Material;

    Slot _Slot;
    Slot _Slot2;

    void Start()
    {
        //���U�C�N�̏���
        _Slot = SpineCG.GetComponent<SkeletonAnimation>().skeleton.FindSlot("gun");
        SpineCG.GetComponent<SkeletonAnimation>().CustomSlotMaterials[_Slot] = _Material;
        SampleImage.material = _Material;

        //���U�C�N�̏���
        
        SampleImage2.material = _Material;
    }

}
