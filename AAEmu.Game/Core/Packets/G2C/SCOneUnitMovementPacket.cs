using AAEmu.Commons.Network;
using AAEmu.Game.Core.Network.Game;
using AAEmu.Game.Models.Game.Units;
using AAEmu.Game.Models.Game.Units.Movements;

namespace AAEmu.Game.Core.Packets.G2C
{
    public class SCOneUnitMovementPacket : GamePacket // TODO ... SCUnitMovementsPacket
    {
        private readonly uint _id;
        private readonly MoveType _type;

        public SCOneUnitMovementPacket(uint id, MoveType type) : base(0x067, 1)
        {
            _id = id;
            _type = type;
        }

        public override PacketStream Write(PacketStream stream)
        {
            stream.WriteBc(_id);
            stream.Write((byte) _type.Type);
            stream.Write(_type);
            return stream;
        }
    }
}