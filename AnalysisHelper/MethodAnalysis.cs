﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.Semantics;

namespace RoslynTool.CsToLua
{
    internal class MethodAnalysis : CSharpSyntaxWalker
    {
        public bool HaveTypeOf
        {
            get { return m_HaveTypeOf; }
        }

        public override void VisitTypeOfExpression(TypeOfExpressionSyntax node)
        {
            var oper = m_Model.GetOperation(node) as ITypeOfExpression;
            var type = oper.TypeOperand;
            if (null != type) {
                if (type.TypeKind == TypeKind.TypeParameter) {
                    var typeParam = type as ITypeParameterSymbol;
                    if (typeParam.TypeParameterKind == TypeParameterKind.Type) {
                        m_HaveTypeOf = true;
                    }
                }
            }
            base.VisitTypeOfExpression(node);
        }

        internal MethodAnalysis(SemanticModel model)
        {
            m_Model = model;
        }

        private SemanticModel m_Model = null;
        private bool m_HaveTypeOf = false;
    }
}