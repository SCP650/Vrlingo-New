using Normal.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameTagSync : RealtimeComponent<NameTagSyncModel>
{
    public GameObject nameTagObject;
    private void NameTagDidChange(NameTagSyncModel model, bool value)
    {
        ToggleNameTag(value);
    }

    private void ToggleNameTag(bool isTeacher)
    {
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
            if (currentModel.isFreshModel)
                currentModel.isTeacher = PlayerPrefs.GetInt("IsTeacher") == 1;

            ToggleNameTag(currentModel.isTeacher);

            // Register for events so we'll know if the color changes later
            currentModel.isTeacherDidChange += NameTagDidChange;
        }
    }
}
