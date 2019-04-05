
using System;
using System.Diagnostics;
using HappyBirthdate.Day.Annotations;

namespace HappyBirthday.Model
{
    [Serializable]
    class Module
    {
        private readonly ProcessModule _module;

        public string Name => _module.ModuleName;
        public string Path => _module.FileName;

        internal Module([NotNull] ProcessModule module)
        {
            this._module = module;
        }

       
    }
}
