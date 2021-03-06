//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public TweenComponent tween { get { return (TweenComponent)GetComponent(GameComponentsLookup.Tween); } }
    public bool hasTween { get { return HasComponent(GameComponentsLookup.Tween); } }

    public void AddTween(float newStartValue, float newEndValue, float newDuration, bool newRepeat) {
        var index = GameComponentsLookup.Tween;
        var component = CreateComponent<TweenComponent>(index);
        component.startValue = newStartValue;
        component.endValue = newEndValue;
        component.duration = newDuration;
        component.repeat = newRepeat;
        AddComponent(index, component);
    }

    public void ReplaceTween(float newStartValue, float newEndValue, float newDuration, bool newRepeat) {
        var index = GameComponentsLookup.Tween;
        var component = CreateComponent<TweenComponent>(index);
        component.startValue = newStartValue;
        component.endValue = newEndValue;
        component.duration = newDuration;
        component.repeat = newRepeat;
        ReplaceComponent(index, component);
    }

    public void RemoveTween() {
        RemoveComponent(GameComponentsLookup.Tween);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherTween;

    public static Entitas.IMatcher<GameEntity> Tween {
        get {
            if (_matcherTween == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Tween);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherTween = matcher;
            }

            return _matcherTween;
        }
    }
}
