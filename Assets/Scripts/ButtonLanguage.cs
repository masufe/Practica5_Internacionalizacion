using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class ButtonLanguage : MonoBehaviour
{
    public void ChangeToSpanish()
    {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.GetLocale("es");
    }
    public void ChangeToEnglish()
    {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.GetLocale("en");
    }

}
