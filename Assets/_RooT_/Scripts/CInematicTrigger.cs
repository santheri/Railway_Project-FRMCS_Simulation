using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;

[RequireComponent(typeof(Collider))]
public class CInematicTrigger : MonoBehaviour
{
    public enum TriggerType 
    {
        Once,Everytime
    }
    [Tooltip("thi is gameobject triggers director to play")]
    public GameObject triggeringGameObject;
    public PlayableDirector director;
    public TriggerType triggerType;
    public UnityEvent OnDirectorPlay;
    public UnityEvent OnDirectorFinish;

    protected bool m_AlreadyTriggered;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject != triggeringGameObject)
            return;
        if (triggerType == TriggerType.Once && m_AlreadyTriggered)
            return;
        OnDirectorPlay.Invoke();
        director.Play();
        m_AlreadyTriggered = true;
        //Invoke("FinishInvoke", (float)director.duration);
        if (Input.GetKeyDown(KeyCode.F))
        {
            FinishInvoke();
        }

    }
    void FinishInvoke()
    {
        OnDirectorFinish.Invoke();
    }
}
