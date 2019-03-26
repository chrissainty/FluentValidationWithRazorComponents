using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;

namespace BlazorExample.FluentValidation
{
    public class FluentValidationsValidator : ComponentBase
    {
        [CascadingParameter] EditContext CurrentEditContext { get; set; }

        protected override void OnInit()
        {
            if (CurrentEditContext == null)
            {
                throw new InvalidOperationException($"{nameof(FluentValidationsValidator)} requires a cascading " +
                    $"parameter of type {nameof(EditContext)}. For example, you can use {nameof(FluentValidationsValidator)} " +
                    $"inside an {nameof(EditForm)}.");
            }

            CurrentEditContext.AddFluentValidations();
        }
    }
}
