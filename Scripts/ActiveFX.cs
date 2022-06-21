using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveFX : MonoBehaviour
{
    public ParticleSystem FXeffect;

    public void ActiveEffect()
    {
        FXeffect.Play();
    }
}
