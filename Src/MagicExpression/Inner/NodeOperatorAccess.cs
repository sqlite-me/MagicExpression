using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MagicExpression.Inner
{
    internal class NodeOperatorAccess : NodeOperator
    {
        public NodeOperatorAccess(string orginalStr, int orignalIndex)
            : base(NodeType.Operator_Access, ".", orginalStr, orignalIndex)
        {
            this.PropertyName = orginalStr.Trim(' ', '.');
        }

        public NodeData Target { get; set; }

        public string PropertyName { get; }

        public override Expression GetExpression()
        {
            return Expression.PropertyOrField(Target.GetExpression(), PropertyName);
        }
    }

}
