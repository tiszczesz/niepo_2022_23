import myImage from '../Images/sowa.jpg';
const Image = () => {
    return (
        <div>
            Tubędzie obrazek z netu i podpis
            <img src={myImage} alt="sowa" />
        </div>
    )
}

export default Image;