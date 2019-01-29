using System.Collections.Generic;

namespace A19_Ex03_Vova_321924466_Anton_321829707.TemplateMethodPattern
{
    public abstract class TemplateMethodSkeleton
    {
        public abstract Dictionary<string, string> InformationGather();

        public Dictionary<string, string> TemplateMethod(Dictionary<string, string> i_Dictionary)
        {
            i_Dictionary = InformationGather();
            return i_Dictionary;
        }
    }
}