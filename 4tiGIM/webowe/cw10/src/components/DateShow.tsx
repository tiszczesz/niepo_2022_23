

type DateProps = {
    myColor: string,
    userName:string
}

const DateShow = (props: DateProps) => {
    return <div style={{ color: props.myColor }}>
        <h3>Hello from dateShow</h3>
        Witaj: {props.userName}<br />
        Dzisiaj mamy: {new Date().toLocaleDateString()}
    </div>
}

export default DateShow;