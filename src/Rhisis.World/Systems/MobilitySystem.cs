﻿using Rhisis.World.Core;
using Rhisis.World.Core.Components;
using Rhisis.World.Core.Entities;
using Rhisis.World.Core.Systems;
using System;

namespace Rhisis.World.Systems
{
    [System]
    public class MobilitySystem : SystemBase
    {
        public override Func<IEntity, bool> Filter => x => x.HasComponent<ObjectComponent>() && x.HasComponent<MovableComponent>();

        public MobilitySystem(IContext context)
            : base(context)
        {
        }

        public override void Execute()
        {
            foreach (var entity in this.Entities)
            {
                var movableComponent = entity.GetComponent<MovableComponent>();

                if (movableComponent.DestinationPosition.IsZero())
                    continue;

                this.Walk(entity);
            }
        }

        private void Walk(IEntity entity)
        {
            // TODO
        }
    }
}