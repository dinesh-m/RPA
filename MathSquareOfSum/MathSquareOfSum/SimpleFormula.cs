using System.Activities;
using System.ComponentModel;

namespace MathSquareOfSum
{
    /// <summary>
    /// Simple demo class library to demonstrate an activity method in UiPath
    /// </summary>
    public class SimpleFormula : CodeActivity
    {
        /// <summary>
        /// First input int32 parameter
        /// </summary>
        [Category("Input")]
        [RequiredArgument]
        public InArgument<int> FirstNumber { get; set; }

        /// <summary>
        /// Second input int32 parameter
        /// </summary>
        [Category("Input")]
        [RequiredArgument]
        public InArgument<int> SecondNumber { get; set; }

        /// <summary>
        /// Output Result in double
        /// </summary>
        [Category("Output")]
        public OutArgument<double> Result { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            //
            var firstNumber = FirstNumber.Get(context);
            var secondNumber = SecondNumber.Get(context);

            var result = System.Math.Pow((firstNumber + secondNumber), 2);
            Result.Set(context, result);
        }
    }
}
