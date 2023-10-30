using Scorpio.Bougainvillea.States;

namespace Scorpio.Tang.Core.State.Character.Events
{
    public record GenerateEvent(long UserId, long CharacterId, int ServerId, string Name, int Sex, int Image, int HeadId)
    {

    }

    public class GenerateEventStateEventHandler : StateEventHandler<CharacterState, GenerateEvent>
    {
        protected override void Apply(CharacterState state, GenerateEvent @event)
        {
            state.UserId = @event.UserId;
            state.CharacterId = @event.CharacterId;
            state.ServerId = @event.ServerId;
            state.Name = @event.Name;
            state.Sex = @event.Sex;
            state.Image = @event.Image;
            state.Base.HeadId = @event.HeadId;
            state.Base.DefHead = @event.HeadId;
        }
    }
}