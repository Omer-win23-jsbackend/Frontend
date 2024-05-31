using System.ComponentModel.DataAnnotations;

namespace Frontend.Helpers;

public class CheckBoxRequired
{
    public class CheckboxRequired : ValidationAttribute
    {
        public override bool IsValid(object? value) => value is bool b && b;

    }
}
