using System;
using System.Collections.Generic;
using System.Text;
using Uni.Notepad.Localization;
using Volo.Abp.Application.Services;

namespace Uni.Notepad
{
    /* Inherit your application services from this class.
     */
    public abstract class NotepadAppService : ApplicationService
    {
        protected NotepadAppService()
        {
            LocalizationResource = typeof(NotepadResource);
        }
    }
}
