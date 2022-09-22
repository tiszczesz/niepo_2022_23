type Props = {
    result:number
}

const MyComponent3 = (myPrpos:Props) => {

    return (
        <>
        <h3>Komponent 3</h3>
        <div>Wynik działania: {myPrpos.result}</div>
        </>
    )
}

export default MyComponent3;