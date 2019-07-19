using ImageEnhancingUtility;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace crop_upscale_merge
{
    public class DictToListboxConverter : IBindingTypeConverter
    {
        public int GetAffinityForObjects(Type fromType, Type toType)
        {           
           return 100;  
        }

        public bool TryConvert(object from, Type toType, object conversionHint, out object result)
        {
            try
            {
                var a = (from as Dictionary<string, bool>).Keys.Cast<string>().ToList().ToArray();
                result = new ListBox.ObjectCollection(new ListBox(), a);
            }
            catch (Exception ex)
            {
                //this.Log().WarnException("Couldn't convert object to type: " + toType, ex);
                result = null;
                return false;
            }

            return true;
        }
    }

    public class ListboxToListConverter : IBindingTypeConverter
    {
        public int GetAffinityForObjects(Type fromType, Type toType)
        {
            return 100;
        }

        public bool TryConvert(object from, Type toType, object conversionHint, out object result)
        {
            try
            {
                var a = (from as CheckedListBox.CheckedItemCollection).Cast<string>().ToList();
                result = a;
            }
            catch (Exception ex)
            {
                //this.Log().WarnException("Couldn't convert object to type: " + toType, ex);
                result = null;
                return false;
            }

            return true;
        }
    }


}
