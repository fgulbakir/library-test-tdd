public class LibraryTest {
    private Library library;
    private Title title;
    private Member donor;

    @Before
    public void donateTitle () {
        library = new Library ();
        title = new Title ();
        donor = new Member ();
        library.donate (title, donor);

    }

    @Test
    public void donatedTitlesAddedToLibrary () {
        assertTrue (library.contains (title));
    }

    @Test
    public void donatedTitlesHaveOneDefaultRentalCopy () {
        assertEquals (1, title.getRentalCopyCount ());
    }

    @Test
    public void donorsGetTenPriorityPoints () {
        assertEquals (10, donor.getPriorityPoints ());
    }
}