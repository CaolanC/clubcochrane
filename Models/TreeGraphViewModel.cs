namespace CC.Models;

public class TreeGraphViewModel
{
    public List<string> NodeNames { get; set; }

    public TreeGraphViewModel(List<string> node_names)
    {
        NodeNames = node_names;
    }
}