using ConsoleApp2.builderInterface;
using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2.entity;
using System.Globalization;
using ConsoleApp2.utils;

namespace ConsoleApp2.builderImpl
{
    public class teacherbuilder : ITeacherBuilder
    {
        Teacher teacher = new Teacher();
         ITeacherBuilder ITeacherBuilder.setDob(DateTime dob)
        {
            teacher.Dob = dob;
            return this;
        }

         ITeacherBuilder ITeacherBuilder.setName(string name)
        {
            name = ValidatorModule.validateName(name);
            teacher.FullName = RemoveDiacritics(name);
            return this;
        }


         ITeacherBuilder ITeacherBuilder.setShortName()
        {
            this.teacher.ShortName = getShortName(this.teacher.FullName);
            return this;
        }

         static string RemoveDiacritics(string text)
        {
            text = text.Trim();
            string normalizeStr = text.Normalize(NormalizationForm.FormD);
            var textBuilder = new StringBuilder(normalizeStr.Length);
            for (int i = 0; i < normalizeStr.Length; i++)
            {
                char normalizeChr = normalizeStr[i];
                var charCategory = CharUnicodeInfo.GetUnicodeCategory(normalizeChr);
                if (charCategory != UnicodeCategory.NonSpacingMark)
                {
                    textBuilder.Append(normalizeChr);
                }
            }
            return textBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        private string getShortName(string fullName)
        {
            string[] splittedStr = fullName.Split(' ');
            string sep = splittedStr[splittedStr.Length - 1];
            StringBuilder stringBuilder = new StringBuilder(splittedStr.Length - 1 + sep.Length)
                .Append(sep);
            stringBuilder = this.appendShortName(splittedStr, stringBuilder);
            return stringBuilder.ToString();
        }


        private StringBuilder appendShortName(string[] splittedStr, StringBuilder stringBuilder)
        {
            for (int i = 0; i < splittedStr.Length - 1; i++)
            {
                stringBuilder.Append(splittedStr[i][0]);
            }
            return stringBuilder;
        }

        Teacher ITeacherBuilder.build() {
            return teacher;
        }

    }
}
