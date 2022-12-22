using System;
using System.Resources;

namespace SteelSeries.GameSense.Generic
{
    internal static class SR
    {
        private static bool UsingResourceKeys()
        {
            return SR.s_usingResourceKeys;
        }

        internal static string GetResourceString(string resourceKey, string defaultString = null)
        {
            if (SR.UsingResourceKeys())
            {
                return defaultString ?? resourceKey;
            }
            string text = null;
            try
            {
                text = SR.ResourceManager.GetString(resourceKey);
            }
            catch (MissingManifestResourceException)
            {
            }
            if (defaultString != null && resourceKey.Equals(text))
            {
                return defaultString;
            }
            return text;
        }

        internal static string Format(string resourceFormat, object p1)
        {
            if (SR.UsingResourceKeys())
            {
                return string.Join(", ", new object[]
                {
                    resourceFormat,
                    p1
                });
            }
            return string.Format(resourceFormat, p1);
        }

        internal static string Format(string resourceFormat, object p1, object p2)
        {
            if (SR.UsingResourceKeys())
            {
                return string.Join(", ", new object[]
                {
                    resourceFormat,
                    p1,
                    p2
                });
            }
            return string.Format(resourceFormat, p1, p2);
        }

        internal static ResourceManager ResourceManager
        {
            get
            {
                ResourceManager result;
                if ((result = SR.s_resourceManager) == null)
                {
                    result = (SR.s_resourceManager = new ResourceManager(typeof(SR)));
                }
                return result;
            }
        }

        internal static string Arg_NonZeroLowerBound
        {
            get
            {
                return SR.GetResourceString("Arg_NonZeroLowerBound", null);
            }
        }

        internal static string Arg_WrongType
        {
            get
            {
                return SR.GetResourceString("Arg_WrongType", null);
            }
        }

        internal static string Arg_ArrayPlusOffTooSmall
        {
            get
            {
                return SR.GetResourceString("Arg_ArrayPlusOffTooSmall", null);
            }
        }

        internal static string ArgumentOutOfRange_NeedNonNegNum
        {
            get
            {
                return SR.GetResourceString("ArgumentOutOfRange_NeedNonNegNum", null);
            }
        }

        internal static string ArgumentOutOfRange_SmallCapacity
        {
            get
            {
                return SR.GetResourceString("ArgumentOutOfRange_SmallCapacity", null);
            }
        }

        internal static string Argument_InvalidOffLen
        {
            get
            {
                return SR.GetResourceString("Argument_InvalidOffLen", null);
            }
        }

        internal static string Argument_AddingDuplicate
        {
            get
            {
                return SR.GetResourceString("Argument_AddingDuplicate", null);
            }
        }

        internal static string InvalidOperation_EmptyQueue
        {
            get
            {
                return SR.GetResourceString("InvalidOperation_EmptyQueue", null);
            }
        }

        internal static string InvalidOperation_EnumOpCantHappen
        {
            get
            {
                return SR.GetResourceString("InvalidOperation_EnumOpCantHappen", null);
            }
        }

        internal static string InvalidOperation_EnumFailedVersion
        {
            get
            {
                return SR.GetResourceString("InvalidOperation_EnumFailedVersion", null);
            }
        }

        internal static string InvalidOperation_EmptyStack
        {
            get
            {
                return SR.GetResourceString("InvalidOperation_EmptyStack", null);
            }
        }

        internal static string InvalidOperation_EnumNotStarted
        {
            get
            {
                return SR.GetResourceString("InvalidOperation_EnumNotStarted", null);
            }
        }

        internal static string InvalidOperation_EnumEnded
        {
            get
            {
                return SR.GetResourceString("InvalidOperation_EnumEnded", null);
            }
        }

        internal static string NotSupported_KeyCollectionSet
        {
            get
            {
                return SR.GetResourceString("NotSupported_KeyCollectionSet", null);
            }
        }

        internal static string NotSupported_ValueCollectionSet
        {
            get
            {
                return SR.GetResourceString("NotSupported_ValueCollectionSet", null);
            }
        }

        internal static string Arg_ArrayLengthsDiffer
        {
            get
            {
                return SR.GetResourceString("Arg_ArrayLengthsDiffer", null);
            }
        }

        internal static string Arg_BitArrayTypeUnsupported
        {
            get
            {
                return SR.GetResourceString("Arg_BitArrayTypeUnsupported", null);
            }
        }

        internal static string Arg_InsufficientSpace
        {
            get
            {
                return SR.GetResourceString("Arg_InsufficientSpace", null);
            }
        }

        internal static string Arg_RankMultiDimNotSupported
        {
            get
            {
                return SR.GetResourceString("Arg_RankMultiDimNotSupported", null);
            }
        }

        internal static string Argument_ArrayTooLarge
        {
            get
            {
                return SR.GetResourceString("Argument_ArrayTooLarge", null);
            }
        }

        internal static string Argument_InvalidArrayType
        {
            get
            {
                return SR.GetResourceString("Argument_InvalidArrayType", null);
            }
        }

        internal static string ArgumentOutOfRange_BiggerThanCollection
        {
            get
            {
                return SR.GetResourceString("ArgumentOutOfRange_BiggerThanCollection", null);
            }
        }

        internal static string ArgumentOutOfRange_Index
        {
            get
            {
                return SR.GetResourceString("ArgumentOutOfRange_Index", null);
            }
        }

        internal static string ExternalLinkedListNode
        {
            get
            {
                return SR.GetResourceString("ExternalLinkedListNode", null);
            }
        }

        internal static string LinkedListEmpty
        {
            get
            {
                return SR.GetResourceString("LinkedListEmpty", null);
            }
        }

        internal static string LinkedListNodeIsAttached
        {
            get
            {
                return SR.GetResourceString("LinkedListNodeIsAttached", null);
            }
        }

        internal static string NotSupported_SortedListNestedWrite
        {
            get
            {
                return SR.GetResourceString("NotSupported_SortedListNestedWrite", null);
            }
        }

        internal static string SortedSet_LowerValueGreaterThanUpperValue
        {
            get
            {
                return SR.GetResourceString("SortedSet_LowerValueGreaterThanUpperValue", null);
            }
        }

        internal static string Serialization_InvalidOnDeser
        {
            get
            {
                return SR.GetResourceString("Serialization_InvalidOnDeser", null);
            }
        }

        internal static string Serialization_MismatchedCount
        {
            get
            {
                return SR.GetResourceString("Serialization_MismatchedCount", null);
            }
        }

        internal static string Serialization_MissingValues
        {
            get
            {
                return SR.GetResourceString("Serialization_MissingValues", null);
            }
        }

        internal static string Arg_KeyNotFoundWithKey
        {
            get
            {
                return SR.GetResourceString("Arg_KeyNotFoundWithKey", null);
            }
        }

        // Note: this type is marked as 'beforefieldinit'.
        static SR()
        {
            bool flag;
            SR.s_usingResourceKeys = (AppContext.TryGetSwitch("System.Resources.UseSystemResourceKeys", out flag) && flag);
        }

        private static readonly bool s_usingResourceKeys;

        private static ResourceManager s_resourceManager;
    }
}
