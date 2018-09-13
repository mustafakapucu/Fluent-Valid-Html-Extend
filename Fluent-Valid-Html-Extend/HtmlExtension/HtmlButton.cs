using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace Fluent_Valid_Html_Extend.HtmlExtension
{
    public static class HtmlButton
    {
        public static MvcHtmlString CustomButton(this HtmlHelper helper, string buttonText, string buttonName, string cssName = "test")
        {
            TagBuilder tag = new TagBuilder("Button");
            tag.MergeAttribute("name", TagBuilder.CreateSanitizedId(buttonName));
            tag.GenerateId(buttonName);
            tag.InnerHtml = buttonText;
            tag.AddCssClass(cssName);
            return MvcHtmlString.Create(tag.ToString());
        }
        public static MvcHtmlString CustomTextBoxFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression)
        {
            var name = ExpressionHelper.GetExpressionText(expression);
            var metadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            TagBuilder tb = new TagBuilder("input");
            tb.Attributes.Add("type", "text");
            tb.Attributes.Add("name", name);
            tb.Attributes.Add("value", metadata.Model as string);
            tb.Attributes.Add("style", "color:red");
            return new MvcHtmlString(tb.ToString());
        }

    }
}