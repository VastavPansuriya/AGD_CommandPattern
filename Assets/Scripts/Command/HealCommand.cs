﻿using Command.Actions;
using Command.Commands;
using Command.Main;

public class HealCommand : UnitCommand
{
    private bool willHitTarget;

    public HealCommand(CommandData commandData)
    {
        this.commandData = commandData;
        willHitTarget = WillHitTarget();
    }

    public override bool WillHitTarget() => true;

    public override void Execute() => GameService.Instance.ActionService.GetActionByType(CommandType.Heal).PerformAction(actorUnit, targetUnit, willHitTarget);
}
