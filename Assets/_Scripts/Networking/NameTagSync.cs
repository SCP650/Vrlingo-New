using Normal.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameTagSync : RealtimeComponent<NameTagSyncModel>
{
    public GameObject nameTagObject;
    public bool hasTeacherFlag;
    private void Start()
    {
        if (GetComponent<RealtimeTransform>().isOwnedLocallyInHierarchy)
        {
            model.isTeacher = PlayerPrefs.GetInt("IsTeacher") == 1;
        }
    }

    private void NameTagDidChange(NameTagSyncModel model, bool value)
    {
        ToggleNameTag(value);
    }

    private void ToggleNameTag(bool isTeacher)
    {
        hasTeacherFlag = isTeacher;
        nameTagObject.SetActive(isTeacher);
    }

    protected override void OnRealtimeModelReplaced(NameTagSyncModel previousModel, NameTagSyncModel currentModel)
    {
        if (previousModel != null)
        {
            // Unregister from events
            previousModel.isTeacherDidChange -= NameTagDidChange;
        }

        if (currentModel != null)
        {
            // If this is a model that has no data set on it, populate it with the current mesh renderer color.
            if (!currentModel.isFreshModel)
            {
                ToggleNameTag(currentModel.isTeacher);
            }


            // Register for events so we'll know if the color changes later
            currentModel.isTeacherDidChange += NameTagDidChange;
        }
    }
}
