using System.Windows.Forms;
using ExileCore.Shared.Attributes;
using ExileCore.Shared.Interfaces;
using ExileCore.Shared.Nodes;
using System.IO;

namespace Alpha
{
	class AlphaSettings : ISettings
	{
		public ToggleNode Enable { get; set; } = new ToggleNode(false);
		public ToggleNode IsFollowEnabled { get; set; } = new ToggleNode(false);
		[Menu("Toggle Follower")] public HotkeyNode ToggleFollower { get; set; } = Keys.PageUp;
		[Menu("Min Path Distance")] public RangeNode<int> PathfindingNodeDistance { get; set; } = new RangeNode<int>(110, 10, 1000);
		[Menu("Move CMD Frequency")]public RangeNode<int> BotInputFrequency { get; set; } = new RangeNode<int>(90, 10, 250);
		[Menu("Stop Path Distance")] public RangeNode<int> ClearPathDistance { get; set; } = new RangeNode<int>(410, 100, 5000);
		[Menu("Random Click Offset")] public RangeNode<int> RandomClickOffset { get; set; } = new RangeNode<int>(50, 1, 100);
		[Menu("Follow Target Name")] public TextNode LeaderName { get; set; } = new TextNode("");
		[Menu("Movement Key")] public HotkeyNode MovementKey { get; set; } = Keys.T;
		[Menu("Allow Dash")] public ToggleNode IsDashEnabled { get; set; } = new ToggleNode(false);
		[Menu("Dash Key")] public HotkeyNode DashKey { get; set; } = Keys.W;
		[Menu("Follow Close")] public ToggleNode IsCloseFollowEnabled { get; set; } = new ToggleNode(false);
		[Menu("Debug info")] public ToggleNode IsDebugEnabled { get; set; } = new ToggleNode(false);

	}
}