﻿namespace LuaGo.CodeAnalyzer.AST.Expressions
{
    // 定义 NameExpression 类型
    public class NameExpression : IExpression
    {
        public int Line { get; set; }
        public string Name { get; set; }

        public NameExpression(string name, int line)
        {
            Name = name;
            Line = line;
        }
    }
}
