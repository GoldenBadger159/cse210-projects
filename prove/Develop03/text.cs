

public class Text
{  
    private string _text = "";
    private List<string> _texts = new List<string>(){
        "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.",
        "For behold, this is my work and my glory to bring to pass the immortality and eternal life of man.",
        "Go therefore and make disciples of all nations, baptizing them in the name of the Father and of the Son and of the Holy Spirit, teaching them to observe all that I have commanded you; and lo, I am with you always, to the close of the age",
        "And the Lord called his people Zion, because they were of one heart and one mind, and dwelt in righteousness; and there was no poor among them.",
        "Look unto me in every thought; doubt not, fear not. Behold the wounds which pierced my side, and also the prints of the nails in my hands and feet; be faithful, keep my commandments, and ye shall inherit the kingdom of heaven."
    };

    public string Randtext(int index)
    {
        _text = _texts[index];
        return _text;
    }
}