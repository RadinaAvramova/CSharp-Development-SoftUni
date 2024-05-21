using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaCore_Skeleton.Models.Fragments
{
    using System.Runtime.Remoting.Metadata.W3cXsd2001;

    using LambdaCore_Skeleton.Enums;

    public class BaseFragment
    {
        private string name;

        private FragmentType type;

        private int pressureAffection;

        protected BaseFragment(string name, int pressureAffection)
        {
            this.Name = name;
            this.PressureAffection = pressureAffection;
        }

        public string Name { get; protected set; }

        public FragmentType Type { get; protected set; }

        public int PressureAffection { get; protected set; }
    }
}
