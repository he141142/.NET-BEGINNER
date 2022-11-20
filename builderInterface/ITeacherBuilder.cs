using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2.entity;

namespace ConsoleApp2.builderInterface
{
    interface ITeacherBuilder
    {
        ITeacherBuilder setName(string name);
        ITeacherBuilder setDob(DateTime dob);
        ITeacherBuilder setShortName();
        Teacher build();
    }
}
