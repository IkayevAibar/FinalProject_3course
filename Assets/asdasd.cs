// GENERATED AUTOMATICALLY FROM 'Assets/asdasd.inputactions'

using System;
using UnityEngine;
using UnityEngine.Experimental.Input;


[Serializable]
public class Asdasd : InputActionAssetReference
{
    public Asdasd()
    {
    }
    public Asdasd(InputActionAsset asset)
        : base(asset)
    {
    }
    private bool m_Initialized;
    private void Initialize()
    {
        // Player
        m_Player = asset.GetActionMap("Player");
        m_Player_Shoot = m_Player.GetAction("Shoot");
        m_Player_Movement = m_Player.GetAction("Movement");
        m_Player_Spell = m_Player.GetAction("Spell");
        // Player2
        m_Player2 = asset.GetActionMap("Player2");
        m_Player2_Shoot = m_Player2.GetAction("Shoot");
        m_Player2_Movement = m_Player2.GetAction("Movement");
        m_Player2_Spell = m_Player2.GetAction("Spell");
        m_Initialized = true;
    }
    private void Uninitialize()
    {
        m_Player = null;
        m_Player_Shoot = null;
        m_Player_Movement = null;
        m_Player_Spell = null;
        m_Player2 = null;
        m_Player2_Shoot = null;
        m_Player2_Movement = null;
        m_Player2_Spell = null;
        m_Initialized = false;
    }
    public void SetAsset(InputActionAsset newAsset)
    {
        if (newAsset == asset) return;
        if (m_Initialized) Uninitialize();
        asset = newAsset;
    }
    public override void MakePrivateCopyOfActions()
    {
        SetAsset(ScriptableObject.Instantiate(asset));
    }
    // Player
    private InputActionMap m_Player;
    private InputAction m_Player_Shoot;
    private InputAction m_Player_Movement;
    private InputAction m_Player_Spell;
    public struct PlayerActions
    {
        private Asdasd m_Wrapper;
        public PlayerActions(Asdasd wrapper) { m_Wrapper = wrapper; }
        public InputAction @Shoot { get { return m_Wrapper.m_Player_Shoot; } }
        public InputAction @Movement { get { return m_Wrapper.m_Player_Movement; } }
        public InputAction @Spell { get { return m_Wrapper.m_Player_Spell; } }
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
    }
    public PlayerActions @Player
    {
        get
        {
            if (!m_Initialized) Initialize();
            return new PlayerActions(this);
        }
    }
    // Player2
    private InputActionMap m_Player2;
    private InputAction m_Player2_Shoot;
    private InputAction m_Player2_Movement;
    private InputAction m_Player2_Spell;
    public struct Player2Actions
    {
        private Asdasd m_Wrapper;
        public Player2Actions(Asdasd wrapper) { m_Wrapper = wrapper; }
        public InputAction @Shoot { get { return m_Wrapper.m_Player2_Shoot; } }
        public InputAction @Movement { get { return m_Wrapper.m_Player2_Movement; } }
        public InputAction @Spell { get { return m_Wrapper.m_Player2_Spell; } }
        public InputActionMap Get() { return m_Wrapper.m_Player2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(Player2Actions set) { return set.Get(); }
    }
    public Player2Actions @Player2
    {
        get
        {
            if (!m_Initialized) Initialize();
            return new Player2Actions(this);
        }
    }
    private int m_KMSchemeIndex = -1;
    public InputControlScheme KMScheme
    {
        get

        {
            if (m_KMSchemeIndex == -1) m_KMSchemeIndex = asset.GetControlSchemeIndex("KM");
            return asset.controlSchemes[m_KMSchemeIndex];
        }
    }
}
