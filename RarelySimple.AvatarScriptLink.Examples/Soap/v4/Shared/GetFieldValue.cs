﻿using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v4.Shared
{
    public static class GetFieldValue
    {
        public static OptionObject RunScript(OptionObject optionObject, string parameter)
        {
            return RunScript(optionObject.ToOptionObject2015(), parameter).ToOptionObject();
        }

        public static OptionObject2 RunScript(OptionObject2 optionObject, string parameter)
        {
            return RunScript(optionObject.ToOptionObject2015(), parameter).ToOptionObject2();
        }

        public static OptionObject2015 RunScript(OptionObject2015 optionObject, string parameter)
        {
            string[] parameters = parameter.Split(',');
            string fieldNumber = parameters.Length >= 2 ? parameters[1] : "";
            string returnMessage = "The FieldValue is ";

            if (optionObject.IsFieldPresent(fieldNumber))
                returnMessage += optionObject.GetFieldValue(fieldNumber);

            returnMessage += ". Since no FieldObjects were modified, no Forms should be returned.";

            return optionObject.ToReturnOptionObject(ErrorCode.Informational, returnMessage);
        }
    }
}