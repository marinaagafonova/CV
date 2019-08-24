using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AssemblyLibr
{
    public class AboutType
    {
        public Type CurrentType { get; private set; }
        public Type[] Interfaces { get; private set; }
        public object CurrentObject { get; set; }
        public PropertyInfo[] Properties { get; private set; }
        public ConstructorInfo[] Constructors { get; private set; }
        public MethodInfo[] Methods { get; private set; }
        public AboutType(Type currentType)
        {
            CurrentType = currentType;
            Interfaces = currentType.GetInterfaces();
            Properties = currentType.GetProperties();
            Constructors = currentType.GetConstructors();
            Methods = currentType.GetMethods();
        }
        public void RunConstructor(int index, object[] param)
        {
            CurrentObject = Constructors[index].Invoke(param);
        }
        public object RunMethod(int index, object[] param)
        {
            if (Methods[index].IsStatic)
                return Methods[index].Invoke(null, param);
            if (CurrentObject != null)
            {
                ParameterInfo[] list = Methods[index].GetParameters();
                object[] param0 = new object[0];
                if (list.Length == 0)
                    return Methods[index].Invoke(CurrentObject, param0);
                return Methods[index].Invoke(CurrentObject, param);
            }
                
            return null;
        }
        public List<Type> GetParametersOfConstructor(int index)
        {
            List<Type> types = new List<Type>();
            foreach (var item in Constructors[index].GetParameters())
            {
                types.Add(item.ParameterType);
            }
            return types;
        }
        public List<Type> GetParametersOfMethod(int index)
        {
            List<Type> types = new List<Type>();
            foreach (var item in Methods[index].GetParameters())
            {
                types.Add(item.ParameterType);
            }
            return types;
        }
        public List<string> GetProperties()
        {
            List<string> prop = new List<string>();
            foreach (var item in Properties)
            {
                string t = item.PropertyType.Name + " " + item.Name;
                try
                {
                    t += " " + item.GetValue(CurrentObject);
                }
                catch (Exception)
                { }
                prop.Add(t);
            }
            return prop;
        }
        public List<string> GetConstructors()
        {
            List<string> constr = new List<string>();
            foreach (var item in Constructors)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(CurrentType.Name + "(");
                ParameterInfo[] parameters = item.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    sb.Append(parameters[i].ParameterType.Name + " " + parameters[i].Name);
                    if (i + 1 < parameters.Length)
                        sb.Append(", ");
                }
                sb.Append(")");
                constr.Add(sb.ToString());
            }
            return constr;
        }
        public List<string> GetMethods()
        {
            List<string> met = new List<string>();
            foreach (var item in Methods)
            {
                StringBuilder sb = new StringBuilder();
                if (item.IsAbstract)
                    sb.Append("abstract ");
                sb.Append(item.ReturnType.Name + " " + item.Name + "(");
                ParameterInfo[] parameters = item.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    sb.Append(parameters[i].ParameterType.Name + " " + parameters[i].Name);
                    if (i + 1 < parameters.Length)
                        sb.Append(", ");
                }
                sb.Append(")");
                met.Add(sb.ToString());
            }
            return met;
        }
        public List<string> GetInterfaces()
        {
            List<string> inter = new List<string>();
            foreach (var item in Interfaces)
            {
                inter.Add(item.Name);
            }
            return inter;
        }
    }
}
