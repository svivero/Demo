using System;

namespace Demo.CSharp
{
    [Flags] // Allows BitWise operators ie | or & to combine enums
    enum FlagEnums
    {
        None, Left, Right
    }

    public static class FlagsEnumTest
    {
        public static void Sample_CombiningEnumsWithOperators()
        {
            // Valid operators are: = == != < > <= >= + - ^ & | ~ += -= ++ -- sizeof
            FlagEnums leftOrRight = FlagEnums.Left | FlagEnums.Right;
            string result = leftOrRight.ToString(); // result = "Left, Right"
        }

        public static void Sample_TypeSafetyIssues()
        {
            FlagEnums @enum = (FlagEnums)12039;
            // throws a runtime exception because 12039 is not a valid value

            // Type safe way
            FlagEnums enumTypeSafe = Enum.IsDefined(typeof(FlagEnums), 12039) ? (FlagEnums) 12039 : FlagEnums.None;
        }
    }
}
