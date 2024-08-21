﻿
using DSL.Evaluator.LenguajeTypes;
using System;
using System.Collections.Generic;

namespace DSL.Evaluator.AST.Instructions.ObjectDeclaration.CardDeclration
{
    internal class PowerDeclaration : IInstruction
    {
        private readonly CardInfo card;
        private readonly Dictionary<string, object> properties;

        public PowerDeclaration(CardInfo card, Dictionary<string, object> properties)
        {
            this.card = card;
            this.properties = properties;
        }
        public void Execute()
        {
            if (properties.TryGetValue("Power", out object? value))
            {
                var power = (double)value;
                card.Power = power;
            }
            else
            {
                throw new Exception("Card has not Power");
            }
        }
    }
}
