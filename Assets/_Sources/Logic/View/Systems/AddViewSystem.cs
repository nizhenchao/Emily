using System;
using System.Collections;
using System.Collections.Generic;
using Entitas;
using Entitas.Unity;
using UnityEngine;

public class AddViewSystem : ReactiveSystem<GameEntity>
{
    private GameContext _gameContext;

    private Transform _container;

    public AddViewSystem(Contexts contexts) : 
        base(contexts.game)
    {
        _gameContext = contexts.game;

        _container = new GameObject("Game Views").transform;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.View);
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasView && entity.view.viewController == null;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var e in entities)
        {
            GameObject prefab = e.view.prefab;

            GameObject gameObject = PoolManager.Instance.SpawnObject(prefab);
            gameObject.name = e.view.name;

            gameObject.transform.SetParent(_container, false);
            gameObject.Link(e, _gameContext);

            var viewController = gameObject.GetComponent<ViewController>();
            e.view.viewController = viewController;
            gameObject.SetActive(false);
        }
    }
}
