using Uni.Notepad.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Uni.Notepad.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class NotepadController : AbpController
    {
        protected NotepadController()
        {
            LocalizationResource = typeof(NotepadResource);
        }
    }
}