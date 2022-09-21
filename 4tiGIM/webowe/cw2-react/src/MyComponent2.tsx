type Props = {
    date:Date,
    price:number
}

const MyComponent2 = (d:Props) => {
    return (
        <>
        <h1>MyComponent2 {d.date.toLocaleDateString()}</h1>
        <h3>My price={d.price}</h3>
        </>
        
    )
}

export default MyComponent2;