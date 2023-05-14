﻿namespace LuaSharp.CodeAnalyzer.AST.Expressions
{
    // 定义 ParensExpression 类型
    public class ParensExpression : IExpression
    {
        public IExpression Expression { get; set; }

        public ParensExpression(IExpression expression)
        {
            Expression = expression;
        }
    }
}