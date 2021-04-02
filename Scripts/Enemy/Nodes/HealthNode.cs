using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthNode : Node
{
    private EnemyAI ai;
    private float threshold;

    public HealthNode(EnemyAI ai, float threshold)
    {
        this.ai = ai;
        this.threshold = threshold;
    }

    public override NodeState Evaluate()
    {
        Debug.Log("HealthNode: " + ai._currentHealth + " threshold: " + threshold);
        return ai._currentHealth <= threshold ? NodeState.SUCCESS : NodeState.FAILURE;
    }

}
